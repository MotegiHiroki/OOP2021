using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {
        [DisplayName("日付")]
        public DateTime Date { get; set; }//日付
        [DisplayName("記録者")]
        public string Auther { get; set; }//記録者
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }//メーカー
        [DisplayName("車名")]
        public string CarName { get; set; }//車名
        [DisplayName("レポート")]
        public string Report { get; set; }//レポート
        public Image Picture { get; set; }//画像

        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他,
        }

        //データ更新用
        public void UpDate(DateTime date, string auther, MakerGroup maker, string carName, string report, Image picture) {
            this.Date = date;
            this.Auther = auther;
            this.Maker = maker;
            this.CarName = carName;
            this.Report = report;
            this.Picture = picture;
        }
    }



}
