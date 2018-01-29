using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using System.Net;
using System.Web;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer mp = new WindowsMediaPlayer();
        private IWMPMediaCollection media;
        private bool IsPlaying = false;
        private String[] urls = { "http://193.200.42.211:80/pulstranceHD.mp3","http://163.172.169.217:80/asp-s", "http://185.40.31.39:7999/1/;.m3u" };
        // Lounge stream: http://138.201.132.27:8444/stream
        private String selected = "";
        private String host = "google.com";
        private byte[] buffer1;
        private byte[] buf = new byte[100000];
        private int timeout;
        private WebRequest request1;
        private WebRequest request2;
        private WebRequest request3;
        private HttpWebResponse response1 = null;
        private HttpWebResponse response2 = null;
        private HttpWebResponse response3 = null;
        private Ping myPing;
        private PingReply reply;
        private PingOptions pingOptions;
        private HttpClient client = new HttpClient();
        private HttpResponseMessage response;
        private int n;
        private int errorState = 0;
        private Timer timer;
        private Timer timer2;
        private ArrayList list = new ArrayList();
        private String metaDataString;
        private String metaString;
        private String[] title;
        private String[] stuff;
        private String Artist;
        private ArrayList chars1 = new ArrayList();



        public Form1()
        {

            InitializeComponent();
 
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

            panel1.Height = this.Height - 40;
            panel1.Width = this.Width - 19;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Setting values into initialized variables
            myPing = new Ping();
            buffer1 = new byte[32];
            timeout = 1000;
            pingOptions = new PingOptions();
            mp.URL = "";
            media = mp.mediaCollection;
            mp.settings.volume = VolumeSlider.Value * 7;
            request1 = WebRequest.Create("http://193.200.42.211:80/pulstranceHD.mp3");
            request2 = WebRequest.Create("http://163.172.169.217:80/asp-s");
            request3 = WebRequest.Create("http://185.40.31.39:7999/1/;.m3u");
            timer = new Timer();
            timer.Interval = (3 * 1000);
            timer.Tick += new EventHandler(timer_tick);
            timer2 = new Timer();
            timer2.Interval = (3 * 1000);
            timer2.Tick += new EventHandler(timer2_tick);
            this.MaximizeBox = false;


            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            //Checking if there is an established connection to the internet
            try
            {
                reply = myPing.Send(host, timeout, buffer1, pingOptions);
            }
            catch
            {
                errorState = 1;
                timer2.Start();
            }

            //try
            //{
                //response1 = (HttpWebResponse)request1.GetResponse();
                //response2 = (HttpWebResponse)request2.GetResponse();
                //response3 = (HttpWebResponse)request3.GetResponse();

            //}catch
            //{
              //  MessageBox.Show("You are currently disconnected from the internet! Music streaming services will not be available without a connection!", "Notice");
                //errorState = 1;
            //}


            if (errorState != 1)
            {
                timer.Start();
            }

            //Checking if the streams are currently online, if not disable the connection and the assigned button
          //  if (response1 == null || response1.StatusCode != HttpStatusCode.OK)
            //{
               // MessageBox.Show("Note: Trance stream is currently down!","Notice");

            //}
            

            //Load Saved Favorite Songs
            list = Properties.Settings.Default.Songs;
            if (list != null)
            {
                foreach (String list2 in list)
                {
                    FavBox.Items.Add(list2);
                }
            }

        }


        //If stream is online
        public void timer_tick(object sender, EventArgs e)
        {
            if (errorState == 1)
            {
                errorState = 1;
            }else if (IsPlaying != true)
            {
                return;
            }
            else
            {
                GetMetaDataStream();
            }
        }


        //If there is not established connection to the internet
        public void timer2_tick(object sender, EventArgs e)
        {
            try
            {
                reply = myPing.Send(host, timeout, buffer1, pingOptions);
            }
            catch
            {
                errorState = 1;
                return; 
            }
            errorState = 0;
            MessageBox.Show("Stream services are now available.","Notice");
            timer2.Stop();
            timer.Start();
            return;
        }

        

        //Function that reads in infromation from the stream and formats the metadata to display in the application
        public async void GetMetaDataStream()
        {

            try
            {
                client.DefaultRequestHeaders.Add("Icy-MetaData", "1");
                response = await client.GetAsync(selected, HttpCompletionOption.ResponseHeadersRead);
                client.DefaultRequestHeaders.Remove("Icy-MetaData");
            }
            catch (HttpRequestException e)
            {
                playButton.Image = Properties.Resources.if_button_grey_play_50039;
                playButton.Refresh();
                playButton.Update();
                playButton.Invalidate();
                mp.controls.pause();
                IsPlaying = false;
                errorState = 1;
                timer.Stop();
                timer2.Start();
                return;
            }
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<string> headerValues;
                if (response.Headers.TryGetValues("icy-metaint", out headerValues))
                {
                    string metaIntString = headerValues.First();
                    if (!string.IsNullOrEmpty(metaIntString))
                    {
                        int metadataInterval = int.Parse(metaIntString);
                        byte[] buffer = new byte[metadataInterval+10];
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            int numBytesRead = 0;
                            int numBytesToRead = metadataInterval;
                            do
                            {
                                try
                                {
                                    n = stream.Read(buffer, numBytesRead, 10);
                                }catch
                                {
                                    errorState = 1;
                                    timer.Stop();
                                    return;
                                }
                                numBytesRead += n;
                                numBytesToRead -= n;
                            } while (numBytesToRead > 0);

                            int lengthOfMetaData = stream.ReadByte();
                            int metaBytesToRead = lengthOfMetaData * 16;
                            byte[] metadataBytes = new byte[metaBytesToRead];
                            try
                            {
                                var bytesRead = await stream.ReadAsync(metadataBytes, 0, metaBytesToRead);
                            }catch
                            {
                                errorState = 1;
                                timer.Stop();
                                return;
                            }

                            metaDataString = System.Text.Encoding.UTF8.GetString(metadataBytes);
                            metaString = metaDataString;
                            chars1 = new ArrayList();
                            String s;

                            foreach (var c in metaString)
                            {
                                if (!char.IsControl(c))
                                {
                                    chars1.Add(c);
                                }else
                                {
                                    break;                
                                }
                            }

                            char[] chars2=(char[])chars1.ToArray(typeof(char));
                            s = new String(chars2);
                            if (s.Contains("-"))
                            {
                                    title = Regex.Split(s, "-");
                                    stuff = Regex.Split(title[0], "'");
                                    Artist = stuff[1];
                                if(title.Length > 2)
                                {
                                    title[1] = title[1] + " - " + title[2];
                                }
                                if (s.Contains(";") && s.Contains("'"))
                                {
                                    if (title[1].Length > 4)
                                    {
                                        title[1] = title[1].Substring(1, title[1].Length - 2);
                                        if(title[1].LastIndexOf("'") == title[1].Length - 1)
                                        {
                                            title[1] = title[1].Remove(title[1].LastIndexOf("'"));
                                        }
                                        ArtistLabel.Text = Artist;
                                        TitleLabel.Text = title[1];
                                    }else
                                    {
                                        ArtistLabel.Text = Artist;
                                        TitleLabel.Text = title[1];
                                    }
                                }

                               ArtistLabel.Text = Artist;
                               TitleLabel.Text = title[1];
                            }
                            else
                            {
                               ArtistLabel.Text = "Information Unavailable";
                               TitleLabel.Text = "Information Unavailable";
                            }
     
                            ArtistLabel.Refresh();
                            ArtistLabel.Update();
                            ArtistLabel.Invalidate();
                            TitleLabel.Refresh();
                            TitleLabel.Update();
                            TitleLabel.Invalidate();
                        }
                    }
                }
            }

        }


        //Volume Control functionality
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            mp.settings.volume = VolumeSlider.Value * 7;
        }


        //RadioButton 3(Trance) functionality
        /**
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (mp.isRemote != true && IsPlaying == false)
            {
                selected = urls[0];

            }
            else
            {
                mp.URL = urls[0];
                selected = urls[0];  
            }             
        }*/


        //RadioButton 2(Ambient) functionality
        /**
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (mp.isRemote != true && IsPlaying == false)
            {
                selected = urls[1];
            }
            else
            {

                mp.URL = urls[1];
                selected = urls[1];
            }
        }*/


        //RadioButton 3(House) functionality
        /**
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (mp.isRemote != true && IsPlaying == false)
            {
                selected = urls[2];
            }
            else
            {
                mp.URL = urls[2];
                selected = urls[2];    
            }
        }*/


        //Pause & Play button functionality
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (errorState == 1)
            {
                return;
            }

            if (IsPlaying != true)
            {
                playButton.Image = Properties.Resources.if_button_grey_pause_50038;
                playButton.Refresh();
                playButton.Update();
                playButton.Invalidate();
                //mp.URL = selected;
                selected = URLInputBox.Text;
                mp.URL = selected;
                mp.controls.play();
                IsPlaying = true;
            }

            else
            {
                playButton.Image = Properties.Resources.if_button_grey_play_50039;
                playButton.Refresh();
                playButton.Update();
                playButton.Invalidate();
                mp.controls.pause();
                IsPlaying = false;
            }
        }


        //
        private void aboutMusicStreamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\nAuthor: Richard A. Bravo\nLogo & Button design software: Flaticon.com & logomakr.com", "About Music Streamer");
        }


        //Add Button 
        private void button1_Click(object sender, EventArgs e)
        {
            String test = (ArtistLabel.Text + " - " + TitleLabel.Text);
            if(test.Equals("  -  ") || test.Equals("Information Unavailable - Information Unavailable"))
            {
                return;
            }
            if (!FavBox.Items.Contains(test))
            {
                FavBox.Items.Add(test);
            }
         
        }


        //Remove Button
        private void button2_Click(object sender, EventArgs e)
        {               
                if(FavBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item in order to remove it.", "Error!");
                }else
                {
                    FavBox.Items.RemoveAt(FavBox.SelectedIndex);
                }           
        }


        //
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list = new ArrayList();
            foreach (String item in FavBox.Items)
            {
                list.Add(item.ToString());
            }

            Properties.Settings.Default["Songs"] = list;
            Properties.Settings.Default.Save();
        }


        //
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FavBox.SelectedIndex != -1)
            {
                Clipboard.SetText(FavBox.GetItemText(FavBox.SelectedItem));
            }
        }

       
    }
}
