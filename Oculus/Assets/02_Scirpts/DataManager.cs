using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using AESWithJava.Con;

public class PlayerData
{
    public int coin; //����
    public int hpUp; //�⺻ ü�� ����
    public int hpTimeHeal; //�ð����� ü�� ȸ��
    public int damageUp; //���ݷ� ����
    public int moveSpeedUp; //�̵��ӵ� ����
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance; // �̱�������

    public PlayerData playerData = new PlayerData(); // �÷��̾� ������ ����

    public string path; // ���
    public static int SS; //

    private string key = "asdf";

    private void Awake()
    {
        #region �̱���
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        #endregion

        path = Path.Combine(Application.persistentDataPath, "save");	// ��� ����
        print(path);
    }

    private void Update()
    {
    }

    public void SaveData()
    {
        Debug.Log("������ ����");
        string data = JsonUtility.ToJson(playerData);
        string encryptedData = AESWithJava.Con.Program.Encrypt(data, key); // �����͸� ��ȣȭ
        File.WriteAllText(path + SS.ToString() + ".Json", encryptedData);
    }

    public void LoadData()
    {
        Debug.Log("�����ͷε�");
        try
        {
            string data = File.ReadAllText(path + SS.ToString() + ".Json");
            string decryptedData = AESWithJava.Con.Program.Decrypt(data, key); // �����͸� ��ȣȭ
            playerData = JsonUtility.FromJson<PlayerData>(decryptedData);
        }
        catch (FileNotFoundException)
        {
            Debug.LogWarning($"���� ã�� �� ���� : {path + SS.ToString() + ".Json"}");
        }
        catch (IOException ex)
        {
            Debug.LogError($"���� �б� �Ұ��� : {path + SS.ToString() + ".Json"}\n{ex}");
        }
    }

    void DataSet()
    {
        GameManager.instance.coin = playerData.coin;
    }


    public void DelData()
    {
        if(File.Exists(path + $"{SS}" + ".Json"))
        {
            File.Delete(path + $"{SS}" + ".Json");
        }
        else
        {
            Debug.Log("���̺� ������ �����ϴ�.");
        }
    }

    public void DataClear()
    {
        SS = -1;
        playerData = new PlayerData();
    }

}
