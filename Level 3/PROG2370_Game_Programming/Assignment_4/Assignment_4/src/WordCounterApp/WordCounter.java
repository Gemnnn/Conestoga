// 
// Program ID : Assignment 4
//
// Revision History : Created by Byounguk Min Dec 16, 2021
//

package WordCounterApp;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class WordCounter {

	// Takes input from the user and calculates the word.
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter file name: ");
		String input = scanner.nextLine();
    	String line;
		List<String> newLine = new ArrayList<String>();
		int length = 0;
		
		// Print original data from file
	    try 
	    {
	    	File content = new File(input);
	        Scanner myReader = new Scanner(content);
	        
	        System.out.println("-----------------------");
	        System.out.println("Words from file");
	        System.out.println("-----------------------");
	        
	        while (myReader.hasNextLine()) 
	        {
	          String data = myReader.nextLine();
	          System.out.println(data);
	        }
	        myReader.close();
	        
	    // Print removing special character from file
	    	FileReader fileReader = new FileReader(input); 
	    	BufferedReader bufferedReader = new BufferedReader(fileReader); 
	        System.out.println("-----------------------------------------");
	        System.out.println("Words after removing special characters");
	        System.out.println("-----------------------------------------");

	    	while((line = bufferedReader.readLine()) != null)
	    	{ 
	    		line = line.replaceAll("[0-9-&,./']","");
	    	    line = line.trim();
	    	    if (!line.equals(""))
	    	    {
	    	    	System.out.println(line);
	    	    	newLine.add(line);
	    	    }
	    	} 
	    	fileReader.close();
	    
	    // Calculate the the number of words of each word length

	        System.out.println("--------------------------------");
	        System.out.println("Lenght -- number of words");
	        System.out.println("--------------------------------");
	    	for(int i=0; i<newLine.size(); i++)
	    	{
	    		String letter = newLine.get(i);
	    		
	    		if (length < letter.length())
	    		{
	    			length = letter.length();
	    		}
	    	}
	        for (int j=1; j<=length; j++) 
	        {
	        	int numberOfWords = 0;
	        	for (int k=0; k<newLine.size(); k++)
	        	{
	        		String checkLetter = newLine.get(k);
	        		if(checkLetter.length() == j) 
	        		{
	        			numberOfWords++;
	        		}
	        	}
		        System.out.println(j + " letters -- " + numberOfWords + " words");
	        }
	    }
	    catch (Exception e)
	    {
	    	System.out.println("Error: Error in file open: " + e.getMessage());
	    }
	}
}