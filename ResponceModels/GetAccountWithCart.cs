namespace APBD10.ResponceModels;

public class GetAccountWithCart
{
    public string FirstNameAccount { get; set; }
    public string SecondNameAccount { get; set; }
    public string EmailAccount { get; set; }
    public string PhoneAccount { get; set; }
    public string RoleAccount { get; set; }

    public GetCart cart { get; set; }    
}