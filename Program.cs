using System;

namespace test
{
    enum Models{AUDI, VOLVO,NISSAN, PORSHE} //Нумерация
    class Cars{//Класс
        public int wheels = 4;
        private float speed;
        protected bool isWorking = true;
        public Models models;//модел используется как типа данных

        public static int test = 0;

        public void setValues(float speed, bool isWorking){
            this.speed = speed;
            this.isWorking = isWorking;
        }
        public Cars (int wheels, float speed, bool isWorking){//конструктор
             this.speed = speed;
            this.isWorking = isWorking;
            this.wheels = wheels;
        }
        public virtual void getValues(){// переопеределение в виртуальный метод
            Console.WriteLine("Car speed is "+this.speed +",car working:" + this.isWorking);
        }

        public Cars (){}
    }
    class Trucks : Cars{//Наследование здесь и ниже
        public int passengers;

        public Trucks(int wheels,float speed,bool isWorking,int passengers):base(wheels,speed,isWorking){
            this.passengers = passengers;
        }
        public override void getValues(){
            base.getValues();
            Console.WriteLine("Passengers:" + passengers);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
      //  Cars.test = 23;
         //   Console.WriteLine(Cars.test);
          Cars audi = new Cars(4,230f,true);//объект класса
          audi.models = Models.AUDI;
        //  Console.WriteLine(audi.wheels);
            Trucks man = new Trucks(8, 130f, true, 3);
            man.getValues();
            //Console.WriteLine(man.passengers);
        //  audi.setValues (230f,true);
          audi.getValues();

          Cars volvo = new Cars();
          volvo.wheels = 6;
          volvo.models = Models.VOLVO;
          volvo.setValues(160f,false);
          volvo.getValues();
        }
        
    }
            
}