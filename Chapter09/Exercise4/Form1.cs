using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                // コピーするのディレクトリパス
                string sourceDirName = textBox1.Text;
                // コピー後のディレクトリパス
                string destDirName = textBox2.Text;

                // ディレクトリをコピーする
                CopyDirectory(sourceDirName, destDirName);

                // 完了メッセージを表示する
                MessageBox.Show($"{sourceDirName}を{destDirName}にコピーしました。");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ディレクトリをコピーする。
        /// </summary>
        /// <param name="sourceDirName">コピーするディレクトリ</param>
        /// <param name="destDirName">コピー先のディレクトリ</param>
        public static void CopyDirectory(string sourceDirName, string destDirName) {
           

            // コピー元のディレクトリの属性をコピー先のディレクトリに反映する
            File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));

            // ディレクトリパスの末尾が「\」でないかどうかを判定する
            if (!destDirName.EndsWith(Path.DirectorySeparatorChar.ToString())) {
                // コピー先のディレクトリ名の末尾に「\」を付加する
                destDirName = destDirName + Path.DirectorySeparatorChar;
            }

            // コピー元のディレクトリ内のファイルを取得する


            // コピー元のディレクトリにあるファイルをコピー先のディレクトリにコピーする
            File.Copy(sourceDirName, destDirName + Path.GetFileName(sourceDirName), true);
            
            
            string stBaseName = Path.GetFileNameWithoutExtension(destDirName + Path.GetFileName(sourceDirName) + "_dak");



        }

    }
}
