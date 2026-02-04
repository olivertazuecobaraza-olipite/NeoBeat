using Firebase.Auth;
using Firebase.Auth.Providers;

namespace NeoBeat_Net.Services.FireBase_Authentication;

public class FireBaseAuth : IFireBaseAuth
{
    /*
     
     const firebaseConfig = {
           apiKey: "AIzaSyDTlcb264JfxCFVweNkSJZCoFSbxHPey4I",
           authDomain: "neobeat-3d798.firebaseapp.com",
           projectId: "neobeat-3d798",
           storageBucket: "neobeat-3d798.firebasestorage.app",
           messagingSenderId: "1005304689766",
           appId: "1:1005304689766:web:17e3bbcc7d1cf69e5b69a7"
       };
     
     */
    #region Instance
    
    public FirebaseAuthClient Instance { get; } = new FirebaseAuthClient(new FirebaseAuthConfig
    {
        ApiKey = "",
        AuthDomain = "",
        Providers =
        [
            new EmailProvider()
            //,new GoogleProvider()
        ]
    });
    
    

    
    
    #endregion
    
    #region Methods

    #region Register

    public async Task<bool> RegisterAsync(string username, string password)
    {
        try
        {
            if (!(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)))
            {
                await Instance.CreateUserWithEmailAndPasswordAsync(username, password);
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return false;
    }
    #endregion
    
    #region Login
    
    public async Task<bool> LoginAsync(string username, string password)
    {
        try
        {
            await Instance.SignInWithEmailAndPasswordAsync(username, password);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return false;
    }
    
    #endregion

    #region LogOut
    
    public void LogOutAsync()
    {
        Instance.SignOut();
    }
    
    #endregion

    #region ChangePassword

    public void ChangePasswordAsync(string email)
    {
        Instance.ResetEmailPasswordAsync(email);
    }

    #endregion
    
    #region GetUser
    
    public User GetCurrentUser()
    {
        return Instance.User;
    }
    
    #endregion
    
    #endregion
    
}
