using Ders.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Menyu.CatHouseMenyu
{
    public class RemoveCatByNickname {


        static public void Remove_Cat_By_Nickname(ref CatHouseClass catHouse) {
            string? nickname;

            Console.Clear();

            Console.ResetColor();

            Console.Write("Cat Remove: ");

            Console.Write("Cat NickName: ");

            nickname = Console.ReadLine();

            if (nickname == null)
                nickname = "";

            catHouse.RemoveCat(nickname);
        } 

    }
}
