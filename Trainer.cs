using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    partial class Trainer
    {
       
        /// partial class
        /// 


        int _level;
        string _nickname;
        public int Level { get { return _level; } set { _level = value; } }
        public string Name { get { return _nickname; } set { _nickname = value; } }
        
        public Trainer()
        {
            _level = 0;
            _nickname = "바밤바";
        }


        /// 디폴트 매개변수 사용시 함수의 인자는 반드시 뒷부분 부터 지정해야 한다.
        /// 앞부터 지정할 시 에러 발생
        /// 아래 코드에서 예시는 nickname먼저 지정해야 함 level만 지정하고 nickname지정안 하면
        /// 오류 발생
        ///  

        public Trainer(int level=5, string nickname="바밤바")//디폴트 매개변수 위험성 존재
        {
            _level = level; 
            _nickname = nickname;
        }
        



    }
}
