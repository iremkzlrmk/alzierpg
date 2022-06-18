using UnityEngine;

public class SendButton : NormalButton
{
    [SerializeField] private StorageData data;

    public void onClick()
    {
        // Send data to database
        
        data.reset();
        
        startScene();
    }
}
