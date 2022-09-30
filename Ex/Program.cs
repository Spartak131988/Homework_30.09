int[] hours = new int[24];
string[] records = new string[3];
records[0] = "10-12";
records[1] = "11-13";
records[2] = "9-12";

for (int i = 0; i < records.Length; i++)
{    
    //разбираем строку на цифры
    string[] digits = records[i].Split('-');    
    int start = int.Parse(digits[0]);
    int end = int.Parse(digits[1]);

    for (int j = start; j < end; j++)
    {
        hours[j]++;
    }        
}

int indexMax = 0; 
int max = hours[indexMax];
for (int i = 0; i < hours.Length; i++)
{
    if (hours[i] > max)
    {
        max = hours[i];    
        indexMax = i;        
    } 
}

Console.WriteLine(String.Format("Максимум посетителей c {0} до {1}: {2} чел.", indexMax, indexMax+1, max));