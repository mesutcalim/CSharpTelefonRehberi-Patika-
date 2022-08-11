using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi{
    public class Program{
        static void Main(string[] args){
            PhoneBookAdministration.OldPhoneBook();
            
            string process = "";
            while(process!="exit"){
                Console.Clear();
                Console.WriteLine("\nProgramdan Çıkış için 'exit' giriniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
                process=Console.ReadLine();
                switch(process){
                    case  "1":
                    PhoneBookAdministration.PhoneBookAdd();
                    break;
                    case "2":
                    PhoneBookAdministration.PhoneBookDelete();
                    break;
                    case "3":
                    PhoneBookAdministration.PhoneBookUpdate();
                    break;
                    case "4":
                    PhoneBookAdministration.PhoneBookList();
                    break;
                    case "5":
                    PhoneBookAdministration.PhoneBookSearch();
                    break;
                    case "exit":
                    continue;
                    default:
                    Console.WriteLine("1 ile 5 arasında bir seçim yapınız ya da 'exit' yazıp çıkış yapınız");
                    
                    break;

                    Console.ReadKey();
                }

            }
            

        }
    }
}