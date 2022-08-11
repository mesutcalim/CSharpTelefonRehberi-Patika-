namespace TelefonRehberi{
    class Sabitler{
        public string FirstName{get; set ;}
        public string Surname{get ; set;}
        public string PhoneNumber{get; set;}

        public Sabitler(string firstName,string surname, string phoneNumber){
            FirstName = firstName;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Sabitler(){

        }
    }
}