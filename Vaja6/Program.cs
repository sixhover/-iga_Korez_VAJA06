using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

        public Igralec() { //Ustvari  podatke o igralcu
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id {//vrne igralca
            get
            {
                return id;
            }
        }

        public string U_ime { //vrne ime igralca
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo //vrne geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg //vrne število igralca
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
