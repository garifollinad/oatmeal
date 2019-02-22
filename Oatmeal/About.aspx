<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Oatmeal.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="container">
  <h2>Back to the story of...</h2>
  <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal"> company </button>
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-body">
          <p class="lead">We all agree that breakfast is the most important meal of the day. Yet, too often, we skip the morning meal with the excuse of being in a hurry. Founded in 2017 by entrepreneur Garifollina Dinara who never took the time to eat nutritiously in the morning, "Oatmeals" company aims to redefine breakfast with clean, authentic and healthful products inspired by foodies, artists, entrepreneurs, early birds and busy people.</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        </div>
      </div>
    </div>
  </div>
 </div>
</asp:Content>
