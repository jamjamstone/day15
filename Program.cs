using System.Numerics;

namespace day15
{
    class Item
    {
        string _name;
        int _price;

        public Item() { }   
        public Item(string name, int price) 
        {
            _name = name;
            _price = price;
        }
    }
    class Player
    {
        ~Player() 
        {
            Console.WriteLine("사라진다~");
        }

        Item[] _inven;
        public Player() 
        { 
            _inven = new Item[10];
        }
        
        public void SetItemByIndex(int index, Item item)
        {
            _inven[index] = item;
        }



        /*
        struct Vector2
        {
            int x;
            int y;
            public void PrintXandY()
            {
                Console.WriteLine("X는 Y는 입니다.");
            }

            public Vector2(int posX, int posY)
            {

                x = posX; y = posY;
            }

              public int z
            {
                get;set;//??
            }

        }*/
        /*
        class Player
        {
            Vector2 _playerPos;
            public Player(Vector2 Pos)// 초기화 및 생성자
            {
                _playerPos = Pos;

            }
        }
        */


        internal class Program
        {





            /*복습용
            class Person
            {
                string _name;//멤버 변수==필드
                int _age;
                public void Introudce()
                {
                    Console.WriteLine($"안녕 난 {_name} 이고 , 나이는 {_age}야");
                }
                public string Name//맴버변수와의 상호작용을 위한 인터페이스=도구
                {
                    get { return _name; }
                    set { _name = value; }
                }
                /// <summary>
                /// 메소드 -> 객체가 수행하는 동작을 정의 프로퍼티는 객체의 데이터를
                /// 읽거나 설정 값을 저장하거나 반환
                /// 메소드는 동작을 실행하고 로직을 수행 
                /// </summary>
                public int Age
                {
                    get { return _age; }
                    set
                    {
                        if (value >=0)
                        {
                            _age = value;
                        }
                    }


            }
            */

            static void Main(string[] args)
            {
                /* 복습용
                Person human;//텅 빈거나 마찬가지이다.
                human = new Person();//할당과정을 거처야 한다. =>인스턴스화
                human.Name = "Test";*/

                /*
                Pet pet = new Pet();
                pet.Name = "Teemo";
                pet.Skill = "poison dart";
                pet.Level = 18;
                Pet pet2 = new Pet();
                pet2.Name = "Vein";
                pet2.Skill = "silver arrow";
                pet2.Level = 18;*/
                // 위 코드는 클래스 할당에 하나당 3줄 이상을 쓰고 있어서 가독성이 떨어짐
                //실수의 위험도 크다.
                /*
                Pet pet = new Pet();
                Pet pet2 = new Pet(15);
                Pet pet3 = new Pet("teemo",18,"poison dart");
                */

                /*
                Trainer trainer = new Trainer();
                Console.WriteLine(trainer.Name);
                Console.WriteLine(trainer.Level);
                ///유저에게 이름을 입력받은 후 아무것도 안적으면 이를 판독 후
                ///조건문에 따라 각기 다른방식으로 생성자 호출 가능
                ///
                */



                /*
                int a=new int();// 0으로 할당
                float b= new float();//0으로 할당
                bool c= new bool();//false로 할당*/
                //Vector2 playerPos = new Vector2(2,3);// 임시로 0이 기입되어 있는 임시 구조체 생성
                //임시 구조체를 변수에 복사함
                ///배열에 new를 쓰면 힙 에 공간을 할당하고 주소값을 반환
                ///클래스에 new를 쓰면 생성자 호출 후 힙에 공간할당 후 주소값 반환
                ///구조체에 new를 쓰면 생성자를 호출하고 임시 구조체 생성 후 임시구조체 반환


                //Player player = new Player(new Vector2(4, 4));// 유니티에서 자주 사용
                Player player = new Player();
                

                
                player.SetItemByIndex(0, new Item("blade",12));
                Trainer trainer = new Trainer();
                trainer.PrintMyName();
                



            }
        }
    }
}
