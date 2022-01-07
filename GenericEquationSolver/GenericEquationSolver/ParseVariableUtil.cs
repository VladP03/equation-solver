using System;
using System.Globalization;


namespace ParseVariable
{
    public sealed class ParseVariableUtil
    {
        public static int parseIntoIntegerFromTextbox(string textboxValue)
        {
            try
            {
                return Int32.Parse(textboxValue);
            }catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Variable null");
            }catch (FormatException)
            {
                throw new FormatException("Incorrect format on a variable");
            }catch (OverflowException)
            {
                throw new OverflowException("Number " + textboxValue + " is too big");
            }
        }

        public static double parseIntoDoubleFromTextbox(string textboxValue)
        {
            try
            {
                return Double.Parse(textboxValue, CultureInfo.InvariantCulture);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Variable null");
            }
            catch (FormatException)
            {
                throw new FormatException("Format exception on number: " + textboxValue);
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number " + textboxValue + " is too big");
            }
        }
    }
}
