for(int count = 1; 10 >= count; count++) {
    for(int i = 1; i <= count; i++) {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int count = 10; 1 <= count; count--) {
    for(int i = 1; i <= count; i++) {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int count = 10; count >= 1; count--) {
    int j = 11;
    int i = 1;
    while(i <= count) {
        Console.Write(" ");
        i++;
    }
    while(i <= j) {
        Console.Write("#");
        j--;
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int count = 1; count <= 10; count++) {
    int j = 11;
    int i = 1;
    while(i <= count) {
        Console.Write(" ");
        i++;
    }
    while(i <= j) {
        Console.Write("#");
        j--;
    }
    Console.WriteLine();
}