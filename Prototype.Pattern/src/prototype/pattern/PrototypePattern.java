
package prototype.pattern;



/**
 *
 * @author alper
 */
 class Musteri implements Cloneable{
   int id;
   String ad;  
   
   public void BilgiYazdir(){
       System.out.println(this.ad+" "+this.id); 
   }   
   public Object clone()throws CloneNotSupportedException{  
        return (Musteri)super.clone();  
    } 
}


public class PrototypePattern {
    
    public static void main(String[] args) {
        
        System.out.println("Shallow Copy");
        Musteri m1=new Musteri();
        m1.id=1;
        m1.ad="Alper";
        m1.BilgiYazdir();        

        Musteri m2=new Musteri();
        m2=m1;
        m2.BilgiYazdir();
        
        m2.id=2;
        m1.BilgiYazdir();
        System.out.println("------------------------");
        
        System.out.println("Deep Copy");        
        Musteri m3=new Musteri();
        m3.ad="Mehmet";
        m3.id=3;
        
        Musteri m4=new Musteri();
        try {
            m4=(Musteri)m3.clone();
        } catch (CloneNotSupportedException ex) {
            
        }
        m4.ad="Mustafa";
        m4.id=4;
        m3.BilgiYazdir();
        m4.BilgiYazdir();
        
    }
    
}
