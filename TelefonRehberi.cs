
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi{
    class PhoneBookAdministration{
        public static List<Sabitler> Person = new List<Sabitler>();
        public static void OldPhoneBook(){
            Person.Add(new Sabitler(){FirstName = "MESUT",Surname = "ÇALIM", PhoneNumber = "04377899872"});
            Person.Add(new Sabitler(){FirstName = "BERKENT",Surname = "ARICI", PhoneNumber = "06055987996"});
            Person.Add(new Sabitler(){FirstName = "TUNÇ",Surname = "KÜRTAJ", PhoneNumber = "09876543231"});
            Person.Add(new Sabitler(){FirstName = "MUSTAFA",Surname = "TUNÇOLMAYAN", PhoneNumber = "05344321256"});
            Person.Add(new Sabitler(){FirstName = "AHMET",Surname = "SOYMAYAK", PhoneNumber = "09878767665"});

        }
        public static void PhoneBookAdd(){
            Console.Clear();
            Console.WriteLine("Lütfen bir isim giriniz:  ");
            string firstName=Console.ReadLine().ToUpper();
            Console.WriteLine("Lütfen bir soyisim giriniz:  ");
            string surname=Console.ReadLine().ToUpper();
            Console.WriteLine("Lütfen telefon numarasını giriniz:  ");
            string phoneNumber=Console.ReadLine();

            Person.Add(new Sabitler() {FirstName= firstName, Surname = surname, PhoneNumber = phoneNumber});

            Console.WriteLine(firstName+" "+surname+ " kişisinin numarası başarılı ile kayıt edilmiştir.");
            Console.ReadKey();

            

        }
        public static void PhoneBookDelete(){
            int countPerson=0;
            Console.Clear();
            Console.WriteLine("Silmek istediğiniz kişinin adını yada soyadını yazınız:");
            string nameDelete = Console.ReadLine().ToUpper();
            for(int i=1;i<=Person.Count;++i){
                foreach(var items in Person){
                    if(items.FirstName == nameDelete||items.Surname== nameDelete){
                        countPerson++;
                        Console.WriteLine("Bu kişiyi silmek istiyor musunuz?  "+items.FirstName+" "+items.Surname);
                        Console.WriteLine("Evet: (1) \nHayır: (2)");
                        string confirmDelete=Console.ReadLine();
                        if(confirmDelete=="1"){
                            Person.Remove(items);
                            Console.WriteLine(items.FirstName+" "+items.Surname+" Kişisi başarı ile silinmiştir.");
                            Console.ReadKey();
                            break;
                        }
                        else if(confirmDelete=="2"){
                            Console.WriteLine(items.FirstName+ " "+ items.Surname+ " Kişisini silme işlemi iptal ediliyor.");
                            Console.ReadKey();
                            break;
                        }
                        else{
                            Console.WriteLine("Yanlış değer girdiniz.");
                            Console.ReadKey();
                            break;
                        }

                    }  
                }
            }
            if(countPerson==0){
                Console.WriteLine("Aradığınız kriterlerde bir kişi bulunamamıştır.");
                Console.WriteLine("Yeniden Denemek için : (1)");
                Console.WriteLine("Aramayı sonlandırıp ana menüye dönmek için: (2) ");
                string confirmDelete2= Console.ReadLine();
                if(confirmDelete2=="1"){PhoneBookDelete();}
                else if(confirmDelete2=="2"){return;}
                else{
                    Console.WriteLine("Hatalı değer girdiniz! /nLütfen tekrar deneyiniz:");
                    Console.WriteLine("Yeniden Denemek için : (1)");
                    Console.WriteLine("Aramayı sonlandırıp ana menüye dönmek için: (2) ");
                    confirmDelete2= Console.ReadLine();
                    if(confirmDelete2=="1"){PhoneBookDelete();}
                    else if(confirmDelete2=="2"){return;}
                    else{Console.WriteLine("Tekrar yanlış değer girdiniz ana menüye yönlendiriliyorsunuz..."); 
                    return;}
                }
            }
        }
        public static void PhoneBookUpdate(){
            int countPerson=0;
            Console.Clear();
            Console.WriteLine("Numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
            
            string firstName = Console.ReadLine().ToUpper();
           
            for(int i=0;i<Person.Count;++i){
                foreach(var items in Person){
                    if(items.FirstName == firstName ||items.Surname== firstName ){
                        countPerson++;
                        Console.WriteLine(items.FirstName+" "+ items.Surname+" Kişisi için yeni numarayı giriniz:");
                        items.PhoneNumber= Console.ReadLine();
                        Console.WriteLine(items.FirstName+" "+ items.Surname+" Kişisinin numarası güncellenmiştir.");
                        Console.ReadKey();
                        return;                
                        }
                    else{
                        
                    }

                }
            }
                if(countPerson==0){
                    Console.WriteLine("Aradığınız kriterlere uyan bir kişi bulunamamıştır.");
                    Console.WriteLine("Yeniden Denemek için : (1)");
                    Console.WriteLine("Aramayı sonlandırıp ana menüye dönmek için: (2) ");
                    string confirmUpdate=Console.ReadLine();
                    if(confirmUpdate=="1"){PhoneBookUpdate();}
                    else if(confirmUpdate=="2"){return;}
                    else{
                        Console.WriteLine("Hatalı değer girdiniz! /nLütfen tekrar deneyiniz:");
                        Console.WriteLine("Yeniden Denemek için : (1)");
                        Console.WriteLine("Aramayı sonlandırıp ana menüye dönmek için: (2) ");
                        confirmUpdate= Console.ReadLine();
                        if(confirmUpdate=="1"){PhoneBookUpdate();}
                        else if(confirmUpdate=="2"){return;}
                        else{Console.WriteLine("Tekrar yanlış değer girdiniz ana menüye yönlendiriliyorsunuz..."); 
                        return;}
                        Console.ReadKey();
                }
            }
        }
        public static void PhoneBookList(){
            Console.WriteLine("**********************************Telefon Rehberi**************************************");
            foreach(var items in Person){
                Console.Write("Adı :");
                Console.WriteLine(items.FirstName);
                Console.Write("Soyadı :");
                Console.WriteLine(items.Surname);
                Console.Write("Numarası :");
                Console.WriteLine(items.PhoneNumber);
                Console.WriteLine("-");
            }
            Console.ReadKey();
        }
        public static void PhoneBookSearch(){
            int countPerson=0;
            Console.Clear();
        
            Console.WriteLine("Neye göre arama yapmak istiyorsunuz? /nİsme Göre : (1) /nNumaraya göre : (2)");
            string choiceSearch = Console.ReadLine().ToUpper();
            if(choiceSearch=="1"){
                Console.WriteLine("Arama yapmak istediğiniz adı giriniz :");
                string firstName = Console.ReadLine().ToUpper();
                
                foreach(var items in Person){
                    if(items.FirstName == firstName || items.Surname == firstName){
                        countPerson++;
                        Console.Write("Adı :");
                        Console.WriteLine(items.FirstName);
                        Console.Write("Soyadı :");
                        Console.WriteLine(items.Surname);
                        Console.Write("Numarası :");
                        Console.WriteLine(items.PhoneNumber);
                        Console.WriteLine("-");
                        //Console.ReadKey();
                    }
                }
                
                if(countPerson==0){
                    Console.WriteLine("Aradığınız kriterlerde hiçbir kişi bulunamamıştır.");
                    
                }
                Console.ReadKey();
            }
            else if(choiceSearch=="2"){
                Console.WriteLine("Arama yapmak istediğiniz numarayı giriniz :");
                string phoneNumber = Console.ReadLine();
                for(int i=1;i<=Person.Count;++i){
                foreach(var items in Person){
                    if(items.PhoneNumber == phoneNumber ){
                        Console.Write("Adı :");
                        Console.WriteLine(items.FirstName);
                        Console.Write("Soyadı :");
                        Console.WriteLine(items.Surname);
                        Console.Write("Numarası :");
                        Console.WriteLine(items.PhoneNumber);
                        Console.WriteLine("-");
                    }
                    else{
                        
                    }
                }
                if(countPerson==0){
                    Console.WriteLine("Aradığınız kriterlerde bir kişi bulunamamıştır.");
                    Console.ReadKey();
                }
            }}
            
            return;
        }
    }
}
