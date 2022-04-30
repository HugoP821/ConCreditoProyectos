/// <reference types="cypress" />

beforeEach (()=>{
    
    cy.fixture('dataTest.json').then (function(datos){
        this.dataTest = datos
        
    cy.visit(this.dataTest.url)

    })

})

/* describe ('Pruebas pagina de inicio', function(){
    it('Validacion encabezado superior', function(){

        cy.get('.active > img').should('be.visible')
        cy.get('.active > .custom > h4').contains('Online Banking')

    })

    it('Validacion de columnas', function(){

        cy.get('#online_banking_features > :nth-child(1) > h4').should('be.visible')
        cy.get('#money_map_link').should('be.visible')

    })

    it('Validacion parte inferior (footer)', function(){
        
    })

}) */

describe.only ('Prueba End To End (E2E) transferencia de fondos.', function(){
    it('Transferencia de fondos de cuenta de ahorro a tarjeta de crédito', function(){

        cy.get('#signin_button').click()
        cy.get('#user_login').type(this.dataTest.user)
        cy.get('#user_password').type(this.dataTest.pass)
        cy.get('.btn').click()
        cy.get('#transfer_funds_tab > a').click()
        cy.get('#tf_fromAccountId').select(2)
        cy.get('#tf_toAccountId').select(4)
        cy.get('#tf_amount').type(200)
        cy.get('#tf_description').type('Test transfer founds.')
        cy.get('#btn_submit').click()
        cy.get('#btn_submit').click()
        cy.get('.alert').should('contain.text', 'You successfully submitted your transaction.')
        cy.get('.board-content').should('be.visible')

    })

})