namespace lab1
{
    class SeparatingDigits
    {
        public string separation(int number)
        {
            string result = "не равна";
            int firstDigit = number / 100000,
                secondDigit = (number / 10000) % 10,
                thirdDigit = (number / 1000) % 10,
                forthDigit = (number / 100) % 10,
                fifthDigit = (number / 10) % 10,
                sixthDigit = number % 10;
            if ((firstDigit + secondDigit + thirdDigit) == (forthDigit + fifthDigit + sixthDigit))
            {
                result = "равна";
            }
            return result;
        }
    }
}