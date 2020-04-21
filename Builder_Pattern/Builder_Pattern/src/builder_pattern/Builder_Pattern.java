
package builder_pattern;


public class Builder_Pattern {

  
    public static void main(String[] args) {
        
            Director bayi;      
            AracBuilder oyuncakArabaBuilder=new OyuncakArabaBuilder();
            AracBuilder bmwBuilder=new BmwBuilder();
            
            bayi=new Director(oyuncakArabaBuilder);
            bayi.construct();
            
            Arac arac=bayi.getArac();
            arac.ozellikYazdir();
            
            
            bayi=new Director(bmwBuilder);
            bayi.construct();
            Arac bmw=bayi.getArac();
            bmw.ozellikYazdir();
            
    }
    
}
