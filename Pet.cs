namespace day15
{
    class Pet

    {
        /// <summary>
        /// 생성자 선언을 안하면 기본생성자를 자동생성 하지만 생성자를 생성하면 반드시 
        /// 기본 생성자부터 생성해야 한다.
        /// 
        /// </summary>
        public Pet()
        {
            _name = "teemo";
            Console.WriteLine("Pet 생성");
        }
        public Pet(string name)
        {
            _name = name;
        }
        public Pet(int level)
        {
            _level = level;
            Console.WriteLine($"pet levle ={_level}");
        }
        public Pet(string name, int level, string skill )
        {
            Name = name;
            Level = level;
            Skill = skill;
            Console.WriteLine($"펫 이름은 {_name}, 펫 레벨은 {_level}, 펫 스킬은 {_skill} 입니다.");

        }

        string _name;
        int _level;
        string _skill;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Level { get { return _level; } set { _level = value; } }
        public string Skill { get { return _skill; } set { _skill = value; } }

        public void UseSkill()
        {
            Console.WriteLine($"{_skill}을 사용하였습니다.");
        }


        /// <summary>
        /// 같은 함수명에 매개변수의 자료형이 달라지면 함수에 오버로드를 사용할 수 있다
        /// 이를 통해서 같은 결과를 내는 함수에 다른 자료형이 들어갈 경우에 사용할
        /// 수 있다. 함수를 초과하여 여러번 사용한다는 뜻이다.
        /// </summary>
        public void PrintPetPrice()
        {

        }
        public void PrintPetPrice(int inputNum)
        {

        }
        public void PrintPetPrice(uint inputNum)
        {

        }


    }
}
