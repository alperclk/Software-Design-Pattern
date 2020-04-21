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
public class OyuncakArabaBuilder implements AracBuilder{
    
    private Arac arac;
    public OyuncakArabaBuilder(){
        this.arac=new Arac();
    }
    
    @Override
    public void tekerlekTak() {
        arac.setTekerlek(3);
    }

    @Override
    public void modeliOlustur() {
        arac.setModel("Oyuncak Araba");
    }

    @Override
    public void araciBoya() {
       arac.setBoya("Kırmızı");
    }

    @Override
    public Arac getArac() {
        return this.arac;
    }
    
}
