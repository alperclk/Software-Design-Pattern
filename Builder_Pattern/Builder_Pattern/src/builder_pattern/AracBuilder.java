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
public interface AracBuilder {
    
    public void tekerlekTak();
    public void modeliOlustur();
    public void araciBoya();
    public Arac getArac();
    
}
