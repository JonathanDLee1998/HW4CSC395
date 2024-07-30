public class Buzz {
    public static void Baffle(string blimp) {
        Console.WriteLine(blimp); // 4
        Zippo("ping", -5); // 5
    }
    
    public static void Zippo(string quince, int flag) {
        if (flag < 0) {
            Console.WriteLine(quince + " zoop"); // 6
        } else {
            Console.WriteLine("ik"); // 2
            Baffle(quince); // 3
            Console.WriteLine("boo-wa-ha-ha"); // 7
        }
    }
    
    public static void Main(string[] args) {
        Zippo("rattle", 13); // 1
    }
}

//The value of the parameter blimp when Baffle is invoked is "rattle".
/*ik
rattle
ping zoop
boo-wa-ha-ha*/
