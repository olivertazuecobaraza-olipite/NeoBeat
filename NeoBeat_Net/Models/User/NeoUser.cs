namespace NeoBeat_Net.Models.User;

public class NeoUser
{
    
    #region Attributes
    
    public string IdUser { get; set; }
    public string Name { get; set; }
    public string Username {get; set;}
    public string Email { get; set; }
    public int? Phone { get; set; }
    public string Password { get; set; }

    public string UserImage { get; set; } = string.Empty;
    public int Followers { get; set; } = 0;
    #endregion
    
    #region Constructors
    
    // Empty
    #region EmptyConstructor
    
    public NeoUser()
    {
        this.IdUser = string.Empty;
        this.Name = string.Empty;
        this.Username = string.Empty;
        this.Email = string.Empty;
        this.Phone = null;
        this.Password = string.Empty;
    }

    #endregion
    
    // Full
    #region FullConstructor
    
    public NeoUser(string id, string name, string username, string email, int phone, string password)
    {
        this.IdUser = id;
        this.Name = name;
        this.Username = username;
        this.Email = email;
        this.Phone = phone;
        this.Password = password;
    }

    #endregion
    
    // Semi Full Constructor: string name, string username, string email, string password
    #region SemiFullConstructor
    
    public NeoUser(string name, string username, string email, string password)
    {
        this.IdUser = string.Empty;
        this.Name= name;
        this.Username = username;
        this.Email = email;
        this.Phone = null;
        this.Password = password;
    }
    
    #endregion
    
    #endregion
    
}