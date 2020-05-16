/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerpattern;

import java.util.Arrays;

/**
 *
 * @author alper
 */
public class ObserverPattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        MessageSubscriber s1 = new MessageSubscriber("A");
        MessageSubscriber s2 = new MessageSubscriber("B");
        MessageSubscriber s3 = new MessageSubscriber("C");
        
        MessagePublisher p = new MessagePublisher();
         
        /*p.addObserver(s1);
        p.addObserver(s2);
        p.addObserver(s3);
        */
         new Thread(() -> p.addObserver(s1)).start();
         new Thread(() -> p.addObserver(s2)).start();
         new Thread(() -> p.addObserver(s3)).start();

        p.notifyUpdate(new Message("Mesaj 1"));   
        
        p.removeObserver(s1);
        
         
        p.notifyUpdate(new Message("Mesaj 2")); 
        
        
        
        
         
        
    
    }
    
}
