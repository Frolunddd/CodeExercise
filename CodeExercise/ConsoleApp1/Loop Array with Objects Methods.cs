//	Loop Array with Objects Methods 1

public class Test1
{

    public Car ArrayWithObjects(Car[] carsArr)
    {
        int i = 0;
        int carMedStørstKM = carsArr[0].KM;
        var Car = carsArr[0];

        while (i < carsArr.Length)
        {
            if (carsArr[i].KM > carMedStørstKM)
            {
                carMedStørstKM = carsArr[i].KM;
                Car = carsArr[i];
            }
            i++;
        }
        return Car;
    }
}
public class Car
{
    public int KM = 0;
}