/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int getQuarterFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5 ){
            if (result != 0){
                break;
            } else {
                Console.WriteLine("You can't choose 0 in this programm");
            }
        }
        else{
            Console.WriteLine("You've entered incorrect quarter");
        }
    }
    return result;
}


int quarter = getQuarterFromUser("Enter quarter number");


if (quarter == 1){
    Console.WriteLine($"x in {quarter} lies between 0 and infinity, y in {quarter} lies between 0 and infinity");
} else if (quarter == 2){
    Console.WriteLine($"x in {quarter} lies between 0 and -infinity, y in {quarter} lies between 0 and infinity");
} else if (quarter == 3){
    Console.WriteLine($"x in {quarter} lies between 0 and -infinity, y in {quarter} lies between 0 and -infinity");
} else if (quarter == 4){
    Console.WriteLine($"x in {quarter} lies between 0 and infinity, y in {quarter} lies between 0 and -infinity");
}