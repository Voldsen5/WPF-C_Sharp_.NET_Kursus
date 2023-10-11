using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion07_01
{
    internal class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name { 
            set {
                _name = value;
                NotifyProper("Name");
            } get { return _name; }
        }

        private int _age;
        public int Age {
            set { 
                _age = value;
                NotifyProper("Age");
            }
            get { return _age; }
        }

        private int _weight;
        public int Weight {
            set {
                _weight = value;
                NotifyProper("Weight");
            }
            get { return _weight; }
        }

        private int _score;
        public int Score {
            set {
                _score = value;
                NotifyProper("Score");
            }
            get { return _score; }
        }

        private bool _accepted;
        public bool Accepted {
            set {
                _accepted = value;
                NotifyProper("Accepted");
            }
            get { return _accepted; }
        }

        public Person(string name, int age, int weight, int score, bool accepted) {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Score = score;
            this.Accepted = accepted;
        }

        private void NotifyProper(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
