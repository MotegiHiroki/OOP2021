using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null ;
        

        public int Port { get; set; } //ポート番号
        public string Host { get; set; } //ホスト名
        public string  MailAddr{ get; set; } //メールアドレス
        public string Pass { get; set; } //パスワード
        public bool Ssl { get; set; } //SSL

        //コンストラクタ
        private Settings(){}
        
        //インスタンスの取得
        public static Settings getInstance()
        {
            string filepass = @"./set.xml";
            if (instance == null && File.Exists(@"./set.xml") )
            {
                
                using (var reader = XmlReader.Create(filepass))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var novel = serializer.ReadObject(reader) as Settings;
                    instance = novel;
                }

            }
            else if(instance == null )
            {
                instance = new Settings();
            }

            return instance;
        }

        //送信データ登録
        public void setSendConfig(string host, int port,
                                    string mailaddr, string pass, bool ssl)
        {
            Host = host;
            Port = port;
            MailAddr = mailaddr;
            Pass = pass;
            Ssl = ssl;


            

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
