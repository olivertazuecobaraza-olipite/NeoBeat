using Firebase.Auth;
using Firebase.Auth.Providers;

namespace NeoBeat_Net.Services.FireBase_Authentication;

public interface IFireBaseAuth
{
    // Instance
    public FirebaseAuthClient Instance { get; }
    
    // Methods
    #region Methods

    #region EmailProvider

    // Register / create user with email and password
    public Task<bool> RegisterAsync(String username, String password);
    // Login / Login with email and password
    public Task<bool> LoginAsync(String username, String password);
    // LogOut
    public void LogOutAsync();
    // Change Password
    public void ChangePasswordAsync(string email);
    // Get Current User
    public User GetCurrentUser();

    #endregion


    #region GoogleProvider

    // Register / create user with email and password

    // Login / Login with email and password

    // LogOut

    // Change Password

    #endregion

    #endregion



}