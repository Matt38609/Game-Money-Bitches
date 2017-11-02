using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Actor Class that contains all the actors attributes
public class Actor : MonoBehaviour {

	//Type that will go into Actor Attributes
	public enum Type
	{
		normal,
		fighting,
		flying,
		poison,
		ground,
		rock,
		bug,
		ghost,
		steel,
		fire,
		water,
		grass,
		electric,
		psychic,
		ice,
		dragon,
		dark,
		fairy
	}

	//List of all the Actor Attributes
	public string Name;
	public Type type;
	public string Nickname;
	public float BaseAttack;
	public float BaseDefense;
	public float BaseSpAttack;
	public float BaseSpDefense;
	public float BaseSpeed;

	private float AdjBaseAttack;
	private float AdjBaseDefense;
	private float AdjBaseSpAttack;
	private float AdjBaseSpDefense;
	private float AdjBaseSpeed;

	// this is good. this will allow the instantiater to set all variables
	public Actor(string _name, Type _type, string _nickname, float _baseattack, float _basedefense, float _basespattack, float _basespdefense, float _basespeed, float _adjba, float _adjbd, float _adjbspa, float _adjbspd, float _adjs)
	{
		Name = _name;
		type = _type;
		Nickname = _nickname;
		BaseAttack = _baseattack;
		BaseDefense = _basedefense;
		BaseSpAttack = _basespattack;
		BaseSpDefense = _basespdefense;
		BaseSpeed = _basespeed;

		AdjBaseAttack = _adjba;
		AdjBaseDefense = _adjbd;
		AdjBaseSpAttack = _adjbspa;
		AdjBaseSpDefense = _adjbspd;
		AdjBaseSpeed = _adjs;
	}

	// you can also do constructors that set default properties
	// for example, we can set every actor BaseSpeed to 1.0f if we want
	// if we use this constructor
	public Actor(string _name, Type _type, string _nickname, float _baseattack, float _basedefense, float _basespattack, float _basespdefense, float _adjba, float _adjbd, float _adjbspa, float _adjbspd, float _adjs)
	{
		Name = _name;
		type = _type;
		Nickname = _nickname;
		BaseAttack = _baseattack;
		BaseDefense = _basedefense;
		BaseSpAttack = _basespattack;
		BaseSpDefense = _basespdefense;
		BaseSpeed = 1.0f;

		AdjBaseAttack = _adjba;
		AdjBaseDefense = _adjbd;
		AdjBaseSpAttack = _adjbspa;
		AdjBaseSpDefense = _adjbspd;
		AdjBaseSpeed = _adjs;
	}

	// when we call .ToString() on an actor this will be called
	// see ActorDatabase InitDb function for example
	public override string ToString ()
	{
		return string.Format ("***Class Actor*** Name: {0}, Type: {1}", Name, type);
	}
}