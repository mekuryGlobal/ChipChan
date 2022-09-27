using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEditor;
using UnityEngine.UI; // needed when accessing text elements
using UnityEngine;
using TMPro;


public class MintMenu : MonoBehaviour
{
    private string chain = "ethereum";
    private string network = "goerli"; // mainnet ropsten kovan rinkeby goerli
    private string account;
    private string to;
    public TMP_Text cID;
    private string cid1155;
    private string chainId = "5";
    public string type1155 = "1155";

    #if UNITY_WEBGL
    public void Awake()
    {
        account = PlayerPrefs.GetString("Account");
        to = PlayerPrefs.GetString("Account");
        cid1155 = cID.text;
    }


    public async void MintNFT()
    {
        CreateMintModel.Response nftResponse = await EVM.CreateMint(chain, network, account, to, cid1155, type1155);
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendTransactionData(nftResponse.tx.to, nftResponse.tx.value, nftResponse.tx.gasPrice, nftResponse.tx.gasLimit, nftResponse.tx.data);
            print("Response: " + response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
#endif

}
