﻿using System;
using System.Net.NetworkInformation;
using MyEnum;


namespace Cards
{
	public abstract class BaseCards
	{
		protected string uid;

		protected elementTypes element_type;
		protected cardTypes card_type;
		protected cardProperty card_property;

		protected int card_damage;
		protected string card_name;
		public BaseCards(int damage, string name)
		{
			this.card_damage = damage;
			this.card_name = name;
		}

		public BaseCards(int damage, string name, elementTypes element) :this( damage,  name)
        {
			this.element_type = element; 
		}

		public int getCardDamage()
		{
			return card_damage;
		}

		public string getCardName()
		{
			return card_name;
		}

		public cardTypes getCardType()
        {			
			return card_type;
        }

		public elementTypes getElementTypes()
        {
			return element_type;
        }

		public cardProperty getCardProperty()
        {
			return card_property;
        }
		public string getUID()
		{
			return uid;
		}
	}
}


