// Made by Miroslav Kabát 
// www.MiroslavKabat.cz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnRotate : MonoBehaviour
{
	public bool Checked;

	public GameObject MainCamera;

	public GameObject ImageObject;
	public GameObject ImageObjectChecked;

	// Use this for initialization
	void Start()
	{
		ImageObject.GetComponent<Image>().gameObject.SetActive(!Checked);
		ImageObjectChecked.GetComponent<Image>().gameObject.SetActive(Checked);
	}

	// Update is called once per frame
	void Update()
	{
		ImageObject.GetComponent<Image>().gameObject.SetActive(!Checked);
		ImageObjectChecked.GetComponent<Image>().gameObject.SetActive(Checked);

		MainCamera.GetComponent<MainCameraOrbit>().AutoRotate = Checked;
	}

	public void ChangeChecked()
	{
		this.Checked = !Checked;
	}
}
