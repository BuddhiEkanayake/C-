DisplayMeasurement(10.0);
DisplayMeasurement(0.0);
DisplayMeasurement(20.0);


void DisplayMeasurement(double measurement)
{
    switch (measurement)
    {
        case<0.0:
            Console.WriteLine($"Measured valid is {measurement} is too low");
            break;
        case>15.0:
            Console.WriteLine($"Measured valid is {measurement} is high");
            break;
        default:
            Console.WriteLine($"Measured valid is {measurement} is normal");
            break;
    }
}