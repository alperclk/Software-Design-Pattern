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
public class BmwBuilder implements AracBuilder {
    
    private Arac arac;
    public BmwBuilder(){
        this.arac=new Arac();
    }
    
    @Override
    public void tekerlekTak() {
        arac.setTekerlek(4);
    }

    @Override
    public void modeliOlustur() {
        arac.setModel("Bmw 520i");
    }

    @Override
    public void araciBoya() {
       arac.setBoya("Beyaz");
    }

    @Override
    public Arac getArac() {
        return this.arac;
    }
    
}
