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
public class Director {
    
        private AracBuilder aracBuilder; 

	public Director(AracBuilder aracBuilder) 
	{ 
		this.aracBuilder=aracBuilder;
	} 

	public Arac getArac() 
	{ 
		return this.aracBuilder.getArac();
	} 

	public void construct() 
	{ 
		this.aracBuilder.tekerlekTak();
                this.aracBuilder.modeliOlustur();
                this.aracBuilder.araciBoya();
	} 
    
}
