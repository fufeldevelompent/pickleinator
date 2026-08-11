using System;

class Pickleinator {
    static void Main(string[] args) {
        int batch = 12;
        for (int i = 0; i < args.Length; i++)
            if (args[i] == "--batch") batch = int.Parse(args[i + 1]);
        Console.WriteLine($"pickleinator: brining {batch} jars. timer set. jar anxiety: managed.");
    }
}
