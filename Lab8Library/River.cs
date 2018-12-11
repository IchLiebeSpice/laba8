using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8Library
{
    public class River
    {
        public int Id { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Equals("Буг") &&
                    !value.Equals("НеБуг") &&
                    !value.Equals("ТожеБуг") &&
                    !value.Equals("ТожеНеБуг") &&
                    !value.Equals("Бог") &&
                    !value.Equals("Бох"))
                {
                    MessageBox.Show("Неправильна назва рикалусси Хохляндии.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidNameException();
                }
                else
                {
                    name = value;
                }
            }
        }

        private string region;
        public string Region
        {
            get { return region; }
            set
            {
                if (!value.Equals("М") &&
                    !value.Equals("Н") &&
                    !value.Equals("Т"))
                {
                    MessageBox.Show("Неправильний регіон.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidRegionException();
                }
                else
                {
                    region = value;
                }
            }
        }

        private string pritoki;
        public string Pritoki
        {
            get { return pritoki; }
            set
            {
                if (!value.Equals("Крим") &&
                    !value.Equals("Мико") &&
                    !value.Equals("НеМико"))
                {
                    MessageBox.Show("Неправильна притока.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidPritokiException();
                }
                else
                {
                    pritoki = value;
                }
            }
        }

        private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Ви вказали озеро...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidLenghtException();
                }
                else
                {
                    lenght = value;
                }
            }
        }

        private int dlina;
        public int Dlina
        {
            get { return dlina; }
            set
            {
                if (value > 0 && value < 5000)
                {
                    dlina = value;
                }
                else
                {
                    MessageBox.Show("Неправильна довжина.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidDlinaException();
                }
            }
        }

        public bool HasBridge { get; set; }

        public override string ToString()
        {
            return string.Format("Назва річки: {0} | Регіон: {1} | Притока: {2} | Довжина: {3} Км | Длина: {4} Км | [{5}]\r\n",
                Name, Region, Pritoki,
                Lenght, Dlina,
                HasBridge ? "Пересічна будовина є" : "Пересічна будовина відсутня"); ;
        }
    }
}
