using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);




        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> score = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Sbject = items[1],
                    Score = int.Parse(items[2])
                };

                score.Add(student);
            }
            return score;








        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Sbject)) {
                    //すでにコレクションに科目名が追加されている
                    dict[student.Sbject] += student.Score;
                } else {
                    //コレクションへ科目名を登録
                    dict[student.Sbject] = student.Score;
                }
            }
            return dict;





        }
    }
}
