using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null ;
        public static bool Set { get; private set; } = true;


        public int Port { get; set; } //ポート番号
        public string Host { get; set; } //ホスト名
        public string  MailAddr{ get; set; } //メールアドレス
        public string Pass { get; set; } //パスワード
        public bool Ssl { get; set; } //SSL

        //コンストラクタ
        private Settings() { }
        
        //インスタンスの取得
        public static Settings getInstance()
        {
            string filepass = @"./set.xml";

            if (instance == null && File.Exists(@"./set.xml"))
            {
                try
                {
                    instance = new Settings();
                    using (var reader = XmlReader.Create(filepass))
                    {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var novel = serializer.ReadObject(reader) as Settings;

                        instance.Host = novel.Host;
                        instance.Port = novel.Port;
                        instance.MailAddr = novel.MailAddr;
                        instance.Pass = novel.Pass;
                        instance.Ssl = novel.Ssl;
                    }
                }
                catch
                {
                    Set = false;
                    MessageBox.Show("xmlが正しくありません");
                    
                }
            }
            else if (instance == null)
            {
                instance = new Settings();
            }
            

            return instance;
        }

        //送信データ登録
        public bool setSendConfig(string host, int port,
                                    string mailaddr, string pass, bool ssl)
        {
            Host = host;
            Port = port;
            MailAddr = mailaddr;
            Pass = pass;
            Ssl = ssl;

            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("set.xml", xws))
            {
                var ser = new DataContractSerializer(this.GetType());
                ser.WriteObject(writer, this);
            }
            Set = true;
            return true;

        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";
        }

        public string sPort()
        {
            return 587.ToString();
        }

        public string sMailAddr()
        {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass()
        {
            return "Infosys2021";
        }


    }
}
