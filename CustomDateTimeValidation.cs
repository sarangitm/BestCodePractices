public class DateTimeValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            try
            {
                DateTime dateTime;
                var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/MM/yyyy", CultureInfo.CurrentCulture,
                    DateTimeStyles.None, out dateTime);
                return base.IsValid(isValid);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
