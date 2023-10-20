using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ServerSettings
        {
            public bool announce { get; set; }
            public string bind { get; set; }
            public string gamemode { get; set; }
            public bool encryption { get; set; }
            public int maxplayers { get; set; }
            public string name { get; set; }
            public decimal stream_distance { get; set; }
            public int port { get; set; }
            public bool disallow_multiple_connections_per_ip { get; set; }
            public int limit_time_of_connections_per_ip { get; set; }
            public string url { get; set; }
            public string language { get; set; }
            public int sync_rate { get; set; }
            public int resource_scan_thread_limit { get; set; }
            public int max_ping { get; set; }
            public int min_fps { get; set; }
            public int max_packet_loss { get; set; }
            public bool allow_cef_debugging { get; set; }
            public bool enable_nodejs { get; set; }
            public string csharp { get; set; }
            public bool enable_http_security { get; set; }
            public bool voice_chat { get; set; }
            public int allow_voice_chat_input { get; set; }
            public int voice_chat_sample_rate { get; set; }
            public string fastdl_host { get; set; }
            public bool server_side_weapons_only_mode { get; set; }
            public bool api_threading_debugging { get; set; }
            public string fqdn { get; set; }
            public uint resources_compression_level { get; set; }
            public string node_commandline_flags { get; set; }
            public double synchronization_extrapolation_multiplier { get; set; }
            public int http_threads { get; set; }
            public bool trigger_compression_logging { get; set; }
            public bool trigger_compression_training { get; set; }
            public string trigger_compression_dictionary { get; set; }
            public bool create_fastdl_snapshot { get; set; }
            public bool disable_client_packages_ram_cache { get; set; }
            public string client_packages_shared_folder { get; set; }

            public ServerSettings Settings()
            {
                ServerSettings serverSettings = new ServerSettings();

                serverSettings.announce = announce;
                serverSettings.bind = bind;
                serverSettings.gamemode = gamemode;
                serverSettings.encryption = encryption;
                serverSettings.maxplayers = maxplayers;
                serverSettings.name = name;
                serverSettings.stream_distance = stream_distance;
                serverSettings.port = port;
                serverSettings.disallow_multiple_connections_per_ip = disallow_multiple_connections_per_ip;
                serverSettings.limit_time_of_connections_per_ip = limit_time_of_connections_per_ip;
                serverSettings.url = url;
                serverSettings.language = language;
                serverSettings.sync_rate = sync_rate;
                serverSettings.resource_scan_thread_limit = resource_scan_thread_limit;
                serverSettings.max_ping = max_ping;
                serverSettings.min_fps = min_fps;
                serverSettings.max_packet_loss = max_packet_loss;
                serverSettings.allow_cef_debugging = allow_cef_debugging;
                serverSettings.enable_nodejs = enable_nodejs;
                serverSettings.csharp = csharp;
                serverSettings.enable_http_security = enable_http_security;
                serverSettings.voice_chat = voice_chat;
                serverSettings.allow_voice_chat_input = allow_voice_chat_input;
                serverSettings.voice_chat_sample_rate = voice_chat_sample_rate;
                serverSettings.fastdl_host = fastdl_host;
                serverSettings.server_side_weapons_only_mode = server_side_weapons_only_mode;
                serverSettings.api_threading_debugging = api_threading_debugging;
                serverSettings.fqdn = fqdn;
                serverSettings.resources_compression_level = resources_compression_level;
                serverSettings.node_commandline_flags = node_commandline_flags;
                serverSettings.synchronization_extrapolation_multiplier = synchronization_extrapolation_multiplier;
                serverSettings.http_threads = http_threads;
                serverSettings.trigger_compression_logging = trigger_compression_logging;
                serverSettings.trigger_compression_training = trigger_compression_training;
                serverSettings.trigger_compression_dictionary = trigger_compression_dictionary;
                serverSettings.create_fastdl_snapshot = create_fastdl_snapshot;
                serverSettings.disable_client_packages_ram_cache = disable_client_packages_ram_cache;
                serverSettings.client_packages_shared_folder = client_packages_shared_folder;

                return serverSettings;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGameMode.Text = "freeroam";
            csharpEnabledSelectBox.Text = "disabled";
            voiceChatSampleRatesText.Text = "48000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveData = new ServerSettings()
            {
                announce = checkBox1.Checked,
                bind = serveripTxt.Text,
                gamemode = txtGameMode.Text,
                encryption = checkBox2.Checked,
                maxplayers = Convert.ToInt32(numericUpDown1.Value),
                name = "RAGE:MP Unofficial server",
                stream_distance = numericUpDown2.Value,
                port = Convert.ToInt32(numericUpDown3.Value),
                disallow_multiple_connections_per_ip = checkBox3.Checked,
                limit_time_of_connections_per_ip = Convert.ToInt32(numericUpDown8.Value),
                url = serverURLtxt.Text,
                language = serverLangBox.Text,
                sync_rate = Convert.ToInt32(numericUpDown4.Value),
                resource_scan_thread_limit = Convert.ToInt32(numericUpDown5.Value),
                max_ping = Convert.ToInt32(numericUpDown6.Value),
                min_fps = Convert.ToInt32(numericUpDown7.Value),
                max_packet_loss = Convert.ToInt32(numericUpDown13.Value),
                allow_cef_debugging = checkBox4.Checked,
                enable_nodejs = checkBox5.Checked,
                csharp = csharpEnabledSelectBox.Text,
                enable_http_security = checkBox6.Checked,
                voice_chat = checkBox7.Checked,
                allow_voice_chat_input = Convert.ToInt32(numericUpDown9.Value),
                voice_chat_sample_rate = Convert.ToInt32(voiceChatSampleRatesText.Text),
                fastdl_host = fastDLtxt.Text,
                server_side_weapons_only_mode = checkBox8.Checked,
                api_threading_debugging = checkBox9.Checked,
                fqdn = fqdnTxt.Text,
                resources_compression_level = Convert.ToUInt32(numericUpDown10.Value),
                node_commandline_flags = nodeCmdFlags.Text,
                synchronization_extrapolation_multiplier = Convert.ToInt32(numericUpDown12.Value),
                http_threads = Convert.ToInt32(numericUpDown11.Value),
                trigger_compression_logging = checkBox11.Checked,
                trigger_compression_training = checkBox12.Checked,
                trigger_compression_dictionary = txtCompressionDictionary.Text,
                create_fastdl_snapshot = checkBox13.Checked,
                disable_client_packages_ram_cache = checkBox14.Checked,
                client_packages_shared_folder = txtClientPackagesSharedFolder.Text
            };

            string json = JsonConvert.SerializeObject(saveData, Formatting.Indented);

            //MessageBox.Show(json, "Json Result...");

            try
            {
                 if (!File.Exists("conf.json"))
                {
                    File.Create("conf.json").Dispose();
                    File.WriteAllText("conf.json", json);
                }
                else
                {
                    File.Open("conf.json", FileMode.Open).Dispose();
                    File.WriteAllText("conf.json", json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Application Exception");
            }
        }
    }
}
