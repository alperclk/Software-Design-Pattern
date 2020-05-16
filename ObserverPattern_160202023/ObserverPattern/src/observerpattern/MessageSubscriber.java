/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerpattern;

/**
 *
 * @author alper
 */
public class MessageSubscriber implements Observer 
{
    @Override
    public void update(Message m) {
        System.out.println("MessageSubscriber :: "+this.subscriberName +" " +m.getMessageContent());
    }
    
    String subscriberName="";
    
    public MessageSubscriber(String name){
     this.subscriberName=name;   
    }
}