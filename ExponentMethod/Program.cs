static int GetPower(int baseNum, int powerNum)
{
    int result = 1;

    for (int i = 0; i < powerNum; i++)
    {
        result = result * baseNum;
    }

    return result;
}

Console.WriteLine(GetPower(3, 3));
