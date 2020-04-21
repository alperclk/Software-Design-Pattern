/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package builder_pattern;

/**
 *
 * @author alper
 */
public class Arac implements AracPlani {
    
    private int tekerlekSayisi;
    private String renk;
    private String model;

    public void setTekerlek(int tekerlekSayisi) {
        this.tekerlekSayisi = tekerlekSayisi;
    }

    public void setBoya(String renk) {
        this.renk = renk;
    }

    public void setModel(String model) {
        this.model = model;
    }
    public void ozellikYazdir(){
        System.out.println(""+this.model+""+this.renk+""+this.tekerlekSayisi); 
    }
    
}
