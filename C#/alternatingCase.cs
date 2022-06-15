



using System;

namespace Extensions
{
  public  class StringExt
  {
    public static  ToAlternatingCase (this string s)
    {

    // Define your method here :)
    return this.split("").map(a => a == a.toUpperCase()? a.toLowerCase(): a.toUpperCase()).join("");

    }
  }
}