using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Oknan
{
    public class MainMenu : MonoBehaviour
    {
        
        private GameObject GlobalManager;
        public GameObject pauseMenu;
        public GameObject nFTMenu;
        public GameObject NFTDataMenu;
        public GameObject SignMenu;
        public GameObject TransferMenu;
        public GameObject ContractMenu;
        public GameObject VoucherMenu;
        public GameObject BalanceMenu;
        public GameObject WelcomeMenu;
        public GameObject AchievementText;
        public Text CoinsText;

        // Start is called before the first frame update
        void Awake()
        {
            GlobalManager = GameObject.FindGameObjectWithTag("Global");
            pauseMenu.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                pauseMenu.SetActive(true);
                FindObjectOfType<AudioManager>().Play("Pop");
                Cursor.visible = true;
                Time.timeScale = 0;
            }

        }

        public void OnResumePressed()
        {
            pauseMenu.SetActive(false);
            FindObjectOfType<AudioManager>().Play("Pop");
            Time.timeScale = 1;

        }

        // makes menus pop up

        public void OpenVoucherMenu()
        {
            if (GlobalManager.GetComponent<Global>().globalCoins > 0)
            {
                FindObjectOfType<AudioManager>().Play("Pop");
                VoucherMenu.SetActive(true);
            }
            else
            {
                Debug.Log("Get More Coins!");
            }
        }

        public void OpenNFTDataMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            NFTDataMenu.SetActive(true);
        }

     

        public void OpenSignMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            SignMenu.SetActive(true);
        }

        public void OpenTransferMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            TransferMenu.SetActive(true);
            Time.timeScale = 0;
        }

        public void OpenContractMenu()
        {

            FindObjectOfType<AudioManager>().Play("Pop");
            ContractMenu.SetActive(true);
        }

        public void OpenBalanceMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            BalanceMenu.SetActive(true);
            Time.timeScale = 0;
        }
        // menu close buttons, usually you would subtract a coin once the blockchain call has suceeded, I've just done it here to show you how in the voucher script

        public void CloseVoucherMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            if (GlobalManager.GetComponent<Global>().globalCoins > 0)
            {
                GlobalManager.GetComponent<Global>().globalCoins -= 1;
                CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            }
            VoucherMenu.SetActive(false);
        }

        public void CloseNFTDataMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            NFTDataMenu.SetActive(false);
        }

        

        public void CloseSignMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            SignMenu.SetActive(false);
        }

        public void CloseTransferMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            TransferMenu.SetActive(false);
            Time.timeScale = 1;
        }

        public void CloseContractMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            ContractMenu.SetActive(false);
        }

        public void CloseBalanceMenu()
        {
            FindObjectOfType<AudioManager>().Play("Pop");
            BalanceMenu.SetActive(false);
            Time.timeScale = 1;
        }

        public void OpenNFTMenu()
        {
            nFTMenu.SetActive(true);
        }

        public void CloseNFTMenu()
        {
            nFTMenu.SetActive(false); 
        }

        public void Quit()
        {
            // Clear Account
            PlayerPrefs.SetString("Account", "0x0000000000000000000000000000000000000001");
            // go to login scene
            SceneManager.LoadScene(0);
        }


        public void OpenMarketplace()
        {
            Application.OpenURL("https://marketplace-ui.onrender.com/");
        }
    }
}
