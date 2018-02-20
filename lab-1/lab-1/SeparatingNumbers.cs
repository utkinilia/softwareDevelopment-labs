namespace lab1
{
    class SeparatingDigits
    {
        public string separation(int number)
        {
            string result = "не равна";
            int firstDigit = number / 100000;
            int secondDigit = (number / 10000) % 10;
            int thirdDigit = (number / 1000) % 10;
            int forthDigit = (number / 100) % 10;
            int fifthDigit = (number / 10) % 10;
            int sixthDigit = number % 10;
            if ((firstDigit + secondDigit + thirdDigit) == (forthDigit + fifthDigit + sixthDigit))
            {
                result = "равна";
            }
            return result;
        }
    }
}