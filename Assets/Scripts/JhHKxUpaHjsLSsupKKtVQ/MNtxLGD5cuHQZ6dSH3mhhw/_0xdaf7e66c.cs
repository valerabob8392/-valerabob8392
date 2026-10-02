using UnityEngine;

public class _0xdaf7e66c : MonoBehaviour
{
    public bool IsTimerEnabled;
    private void _0x9e9856b1()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsBestScoreEnabled;
    private void _0xd77ae688()
    {
    }

    public bool IsLevelSelectorEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsStoryEnabled;
    public bool IsSkipSplashEnabled;
    public static _0xdaf7e66c Instance;
    public bool IsOnlyWinGameEndEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xdaf7e66c>();
            DontDestroyOnLoad(this.gameObject);
            this._0x9e9856b1();
        }
        else
        {
            this._0xd77ae688();
            Destroy(this.gameObject);
        }
    }

    public bool IsTutorialEnabled;
}