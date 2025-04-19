namespace BinaryToDecimal.Services
{
    public class BinaryToDecimalService
    {
        public string ConvertToDecimal(string binary)
        {
            var power = binary.Length - 1;
            var result = 0;

            foreach (var c in binary)
            {
                var bit = int.Parse(c.ToString());
                result += (int)Math.Pow(2, power--) * bit;
            }

            return result.ToString();
        }
    }
}
