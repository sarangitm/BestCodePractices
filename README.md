# BestCodePractices
Best coding practices in Asp.Net MCV with EF

## Validations: 
* Add [Required] validatio to string to make it notnull in SQL.
* Add [Stringlength(value)] to string properties.
* For byte, int & long use Min, Max or Range validation attributes.
* For custome validation like for DateTime, you can create custome validation by inheriting class by ValidationAttribute Class & overriding IsValid method. Refer [link](https://github.com/sarangitm/BestCodePractices/blob/master/CustomDateTimeValidation.cs) for details.
