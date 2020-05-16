/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerpattern;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author alper
 */
public class MessagePublisher implements Subject {
     
    private List<Observer> observers = new ArrayList<>();
    private final Object MONITOR = new Object();
    
    @Override
    public void addObserver(Observer o) {
        if(o==null) return;
        
        synchronized(MONITOR){
            observers.add(o);
        }
        
        
    }
 
    @Override
    public void removeObserver(Observer o) {
        if(o==null) return;
        
        synchronized(MONITOR){
            if(!observers.isEmpty()){
                observers.remove(o);
            }
        }
        
    }
 
    @Override
    public void notifyUpdate(Message m) {
        if(observers!=null){
            synchronized(MONITOR){
                for(Observer o: observers) {
                    o.update(m);
                }
            }
        }
        
    }
}