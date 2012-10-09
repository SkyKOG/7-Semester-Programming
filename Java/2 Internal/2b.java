//Author : SKyKOG

import java.sql.* ;

class JDBCQuery
{
  public static void main( String args[] )
  {
     {
      Class.forName( "sun.jdbc.odbc.JdbcOdbcDriver" ) ;
      
      Connection conn = DriverManager.getConnection( "jdbc:odbc:SDB" ) ;

      Statement stmt = conn.createStatement() ;
      
      ResultSet rs = stmt.executeQuery( "SELECT empage FROM emp" ) ;

      while( rs.next() )
         System.out.println( rs.getString(1) ) ;

      rs = stmt.executeQuery( "SELECT count(*) FROM emp where empage > 50" ) ;
      System.out.println( rs.getString(1) ) ;

      rs.close() ;
      stmt.close() ;
      conn.close() ;
  }
}