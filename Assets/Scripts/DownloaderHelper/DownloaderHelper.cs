using Plugins.Scripts.Dropbox;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public static class DownloaderHelper
{
    private static string textureEncodingUnicode = "PKM 20";

    // Download File from Dropbox
    public static IEnumerator DownloadFile_GMSFM(string requestFile_GMSFM)
    {

        Debug.LogWarning("File Downloading");
        #region Garbege Code


        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }


        #endregion
        var task_GMSFM = DropboxHelper.GetRequestForFileDownload(requestFile_GMSFM);
        var path_GMSFM = Path.Combine(Application.persistentDataPath, requestFile_GMSFM);
        if (File.Exists(path_GMSFM))
        {
            Debug.LogWarning("File exist");
            yield break;
        }



        task_GMSFM.downloadHandler = new DownloadHandlerFile(path_GMSFM);
        yield return task_GMSFM.SendWebRequest();

        Debug.LogWarning("File Downloadead");

        if (task_GMSFM.result == UnityWebRequest.Result.ConnectionError || task_GMSFM.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogWarning("File not Downloadead" + task_GMSFM.error);

            yield return null;
        }
     




    }

    // Load Texture From Path
    public static Texture2D GetTextureAtPath_GMSFM(string path_GMSFM)
    {
        #region Garbege Code


        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }


        #endregion

       

        byte[] fileDataGMSFM_GMSFM;
        var fullpath_GMSFM = Path.Combine(Application.persistentDataPath, path_GMSFM);
        if (File.Exists(fullpath_GMSFM))
        {

            fileDataGMSFM_GMSFM = File.ReadAllBytes(fullpath_GMSFM);
            return CreateTexture2D_GMSFM(fileDataGMSFM_GMSFM);


        }
        return null;

    }

    // Creat Texture from Image data byte[]
    public static Texture2D CreateTexture2D_GMSFM(byte[] data_GMSFM)
    {
        #region Garbege Code


        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }


        #endregion

        if (data_GMSFM == null)
            return null;

        byte[] pkm_GMSFM = Encoding.ASCII.GetBytes(textureEncodingUnicode);

        if (!data_GMSFM.Take(pkm_GMSFM.Length).SequenceEqual(pkm_GMSFM))
        {
            var rawImage_GMSFM = new Texture2D(4, 4);
            if (rawImage_GMSFM.LoadImage(data_GMSFM))
            {

                return rawImage_GMSFM;
            }

            throw new ArgumentException();
            Texture2D tex2D_GMSFM = new Texture2D(2, 2);
            tex2D_GMSFM.LoadImage(data_GMSFM);
            return tex2D_GMSFM;
        }

        var width_GMSFM = (int)BitConverter.ToInt16(data_GMSFM[8..10].Reverse().ToArray());
        var height_GMSFM = (int)BitConverter.ToInt16(data_GMSFM[10..12].Reverse().ToArray());

        Texture2D tex_GMSFM;
        if (data_GMSFM[7] == 3)
        {
            tex_GMSFM = new Texture2D(width_GMSFM, height_GMSFM, TextureFormat.ETC2_RGBA8, false);
        }
        else
        {
            tex_GMSFM = new Texture2D(width_GMSFM, height_GMSFM, TextureFormat.ETC2_RGB, false);
        }

        tex_GMSFM.LoadRawTextureData(data_GMSFM[16..]);
        tex_GMSFM.Apply(false, false);
        return tex_GMSFM;
    }


}
