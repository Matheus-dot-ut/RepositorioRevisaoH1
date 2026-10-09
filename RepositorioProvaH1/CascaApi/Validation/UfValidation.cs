using System.ComponentModel.DataAnnotations;
public class UfValidation : ValidationAttribute
    {
    public override bool IsValid(object? value)
    {
        if (value == null)
        {
            return false;
        }

        string uf = value.ToString()!.Trim().ToUpper();

        if (uf == "MG" || uf == "SP" || uf == "RJ" || uf == "ES")
        {
            return true;
        }

        return false;
    }
}